"use strict";
var React = require('react');
var CandidateList = require('./candidateList.jsx');
var SearchCriteria = require('./searchCriteria.jsx');
var FormLayout = require('../Common/Layouts/formLayout.jsx');
var CandidateActions = require('../../actions/candidateActions.js');

var Candidates = React.createClass({
    getInitialState: function () {
        return {
            criteria: { keywords: '', ethnicity: [] },
            searchResults:[]
        };
    },

    setCriteriaState: function(event) {
        var field = event.target.name;
        var value = event.target.value;
        this.state.criteria[field] = value;
        return this.setState({criteria: this.state.criteria});
    },
    
    searchCandidates: function () {
        
        CandidateActions.search(this.state.criteria)
            .then(function searchSuccess(results) {
                this.setState({ searchResults: results.hits });
        }.bind(this))
            .catch(function searchError(err) {
                console.error(err);
            });
    },

    render: function () {
        var candidates = (
           <div className="container">                
                   <div className="row">
                       <div className="col-xs-12 col-sm-4 col-md-4"><SearchCriteria criteria={this.state.criteria} onchange={this.setCriteriaState} onsubmit={this.searchCandidates} /></div>
                       <div className="col-xs-12 col-sm-8 col-md-8"><CandidateList candidates={this.state.searchResults} /></div>
                   </div>
           </div>
            );
        return (
            <FormLayout content={candidates} pageTitle="Recruiting" />
            );
    }
});

module.exports = Candidates;