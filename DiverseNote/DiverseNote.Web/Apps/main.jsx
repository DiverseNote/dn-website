var React = require('react');
var Router = require('react-router');
var routes = require('./Common/routes.jsx');

var App = require('./Common/app.jsx');

Router.run(routes, function (Handler) {
    React.render(<Handler />, document.getElementById('app'));
});
