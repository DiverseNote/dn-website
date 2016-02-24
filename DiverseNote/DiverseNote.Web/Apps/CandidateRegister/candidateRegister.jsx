"use strict";
var React = require('react');
var CandidateRegisterForm = require('./candidateRegisterForm.jsx');
var FormLayout = require('../Common/Layouts/formLayout.jsx');

var CandidateRegister = React.createClass({
    render: function () {

        var candidateRegister = (
               <div className="container">
                        <div className="row">
                             <div className="col-xs-12 col-sm-9 col-md-9"><CandidateRegisterForm /></div>
                             <div className="col-xs-12 col-sm-3 col-md-3"><h3>Be recruited by these companies</h3></div>
                        </div>
               </div>
            );
        return (
                <FormLayout content={candidateRegister} />
            );       
    }
});

module.exports = CandidateRegister;