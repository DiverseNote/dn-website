'use strict';

var React = require('react');
var Router = require('react-router');
var IndexRoute = Router.IndexRoute;
var Route = Router.Route;

var App = require('./app.jsx');
var Landing = require('../landing/landing.jsx');
var Candidates = require('../candidateSearch/candidates.jsx');
var CandidateRegister = require('../candidateregister/candidateRegister.jsx');
var Register = require('../register/register.jsx');

var routes = (
    <Route name="app" path="/" component={App}>
        <IndexRoute component={Landing} />
        <Route path="candidatesearch" component={Candidates} />
        <Route path="candidateregister" component={CandidateRegister} />
        <Route path="register" component={Register} />  
    </Route>
    );

module.exports = routes;