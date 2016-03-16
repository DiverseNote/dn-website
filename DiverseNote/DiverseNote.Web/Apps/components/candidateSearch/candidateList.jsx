"use strict";

var React = require('react');
var CandidateItem = require('./candidateItem.jsx');

var CandidateList = React.createClass({

    render: function () {
        var candidateItems = [];
        if (this.props.candidates.length > 0){
            this.props.candidates.forEach(function (candidate) {
                    var skills = '';
                    if(candidate.Skills !== undefined && candidate.Skills !== null)
                    skills = candidate.Skills.map(function (skill) {
                        return skill.Name;
                    }).join();

                    candidateItems.push(<CandidateItem candidate={candidate} key={candidate.Id } skills={skills} />);
                }
            );
        }
        return (<div>{candidateItems}</div>);
    }
});

module.exports = CandidateList;
