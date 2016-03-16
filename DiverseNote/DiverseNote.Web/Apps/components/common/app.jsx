jQuery = require('jquery');
$ = jQuery;
var React = require('react');
var Candidates = require('./../CandidateSearch/candidates.jsx');
var CandidateRegistration = require('./../CandidateRegister/candidateRegister.jsx');
var Landing = require('./../Landing/landing.jsx');
var RouteHandler = require('react-router').RouteHandler;

var App = React.createClass({
    render: function () {
        return (
                <div className="app-container">                                                               
                        <RouteHandler />
                </div>
            );
    }
});

module.exports = App;