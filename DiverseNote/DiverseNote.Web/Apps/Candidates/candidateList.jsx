"use strict";

var React = require('react');
var CandidateItem = require('./candidateItem.jsx');

var CandidateList = React.createClass({
    render: function () {
        var candidateItems = [];
        this.props.candidates.forEach(function (candidate) {
            candidateItems.push(<CandidateItem candidate={candidate} key={candidate._id } />);
        }
);
        return (<div>{candidateItems}</div>);
    }
});

module.exports = CandidateList;
