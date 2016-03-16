'use strict';

var React = require('react');
var Router = require('react-router');
var DefaultRoute = Router.DefaultRoute;
var Route = Router.Route;

var routes = (
    <Route name="app" path="/" handler={require('./app.jsx')}>
        <DefaultRoute handler={require('../Landing/landing.jsx')} />
        <Route name="candidates" handler={require('./../CandidateSearch/candidates.jsx')} />
        <Route name="candidateregister" handler={require('./../CandidateRegister/candidateRegister.jsx')} />
        <Route name="register" handler={require('./../Register/register.jsx')} />  
    </Route>
    );

module.exports = routes;