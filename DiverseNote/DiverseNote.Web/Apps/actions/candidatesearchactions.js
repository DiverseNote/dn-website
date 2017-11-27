"use strict";
var algoliaSearch = require('algoliasearch');
var React = require('react');

var CandidateSearchActions = {
    
    search: function(criteria) {
        var client = algoliaSearch('4CRFUF79Y0', '99c295df3361f36e02794663706de3f8');
        var index = client.initIndex('candidates');
        var tags = [];

        if (criteria.experience.length === 1)
            tags.push(criteria.experience[0]);

        if (criteria.experience.length > 1)
            tags.push("(" + criteria.experience.join(",") + ")");

        if (criteria.gender.length === 1)
            tags.push(criteria.gender[0]);

        if (criteria.gender.length > 1)
            tags.push("(" + criteria.gender.join(",") + ")");

        if (criteria.ethnicity.length === 1)
            tags.push(criteria.ethnicity[0]);

        if (criteria.ethnicity.length > 1)
            tags.push("(" + criteria.ethnicity.join(",") + ")");
        
        return index.search(criteria.keywords, { hitsPerPage: 25, tagFilters: tags.join(",")});
      
    }
};

module.exports = CandidateSearchActions;