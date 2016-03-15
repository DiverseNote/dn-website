/// <binding BeforeBuild='copyunderscore, copyreactdom, copyreact, copyjquery, copygriddle, copybootstrap' ProjectOpened='copybootstrap, copygriddle, copyjquery, copyreact, copyreactdom, copyunderscore' />
var gulp = require("gulp");
var connect = require('gulp-connect');//Runs a local dev server
var open = require('gulp-open'); //Open a URL in a web browser
var browserify = require('browserify'); //Bundles JS
var reactify = require('reactify'); //Transforms jsx to js
var source = require('vinyl-source-stream'); //Use conventional text streams with Gulp
var concat = require('gulp-concat'); //Concatenates files
var lint = require('gulp-eslint'); //Lint JS files, including JSX

var config = {
    port: 62785,
    devBaseUrl: 'http://localhost',
    paths: {
        html: './Apps/components/*.html',
        js: [
            './node_modules/bootstrap/dist/js/bootstrap.js'//TODO: Replace with require for react-bootstrap
        ],
        css:[
            './node_modules/bootstrap/dist/css/bootstrap.min.css',
            './node_modules/bootstrap/dist/css/bootstrap-theme.min.css',
            './Styles/*.css'
        ],
        fonts: './node_modules/bootstrap/dist/fonts/*',
        images: './Images/**/*',
        dist: './dist',
        mainJs: './Apps/main.jsx'
    }
}

//Start a local dev server
gulp.task('connect', function () {
    connect.server({
        root: ['dist'],
        port: config.port,
        base: config.devBaseUrl,
        livereload: true
    });
})

//open the app in the browser
gulp.task('open', ['connect'], function () {
    gulp.src('dist/index.html').pipe(open({ uri: config.devBaseUrl + ':' + config.port + '/' }))
})

//copy the html files to the distribution folder, then reload the browser
gulp.task('html', function () {
    gulp.src(config.paths.html).pipe(gulp.dest(config.paths.dist)).pipe(connect.reload());
})

//copy the js files to the distribution folder
gulp.task('mainJs', function () {
    browserify(config.paths.mainJs)
    .transform(reactify) //compile jsx
    .bundle().on('error', console.error.bind(console)) //place errors in the console
    .pipe(source('bundle.js'))
    .pipe(gulp.dest(config.paths.dist + '/scripts'))
    .pipe(connect.reload());
})

//copy the css files to the distribution folder
gulp.task('css', function () {
    gulp.src(config.paths.css)
        .pipe(concat('bundle.css'))
        .pipe(gulp.dest(config.paths.dist + '/css'));        
})

//copy the js files to the distribution folder
gulp.task('js', function () {
    gulp.src(config.paths.js)
        .pipe(concat('ref-bundle.js'))
        .pipe(gulp.dest(config.paths.dist + '/scripts'));
})

//copy the js files to the distribution folder
gulp.task('fonts', function () {
    gulp.src(config.paths.fonts)
        .pipe(gulp.dest(config.paths.dist + '/fonts'));
})

//copy the css files to the distribution folder
gulp.task('images', function () {
    gulp.src(config.paths.images)
        .pipe(gulp.dest(config.paths.dist + '/Images'));
})

//prints javascript errors to the console
gulp.task('lint', function () {
    return gulp.src(config.paths.js)
    .pipe(lint({ config: 'eslint.json' }))
    .pipe(lint.format());
})

//watches for changes and calls to reload the browser -- installed livereload chrome extension
gulp.task('watch', function () {
    gulp.watch(config.paths.html, ['html']);
    gulp.watch(config.paths.js, ['js']);
    gulp.watch(config.paths.mainJs, ['mainJs']);
    gulp.watch(config.paths.css, ['css']);
})

gulp.task('default', ['html', 'js', 'mainJs', 'css', 'images', 'open', 'watch']);
