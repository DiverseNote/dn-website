var React = require('react');
var ReactRouter = require('react-router');
var ReactDOM = require('react-dom');
var Router = ReactRouter.Router;
var Route = ReactRouter.Route;
var routes = require('./components/common/routes.jsx');
var App = require('./components/common/app.jsx');

ReactDOM.render(<Router routes={routes} />, document.getElementById('app'));

