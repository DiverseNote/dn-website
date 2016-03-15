var React = require('react');
var Router = require('react-router');
var routes = require('./components/common/routes.jsx');

var App = require('./components/common/app.jsx');

Router.run(routes, function (Handler) {
    React.render(<Handler />, document.getElementById('app'));
});
