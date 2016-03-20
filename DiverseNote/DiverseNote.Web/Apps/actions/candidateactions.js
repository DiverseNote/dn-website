"use strict";
var algoliaSearch = require('algoliasearch');
var React = require('react');

var CandidateActions = {
    search: function(criteria) {
        var client = algoliaSearch('4CRFUF79Y0', '99c295df3361f36e02794663706de3f8');
        var index = client.initIndex('candidates');
        return index.search(criteria.keywords);
    }
};

module.exports = CandidateActions;