"use strict";
var Bloodhound = require('bloodhound-js');
var TypeAhead = require('typeahead');
var React = require('react');
var Mustache = required('mustache');

var TypeAheadActions = {
    search: function (searchTerm, source, controlid) {
        var idref = '#' + controlid;
        $(idref + ' .typeahead').typeahead(null, {
            name: 'dv-typeahead',
            display: 'value',
            source: source,
            templates: {
                suggestion: Handlebars.compile('<div>{{value}} – {{year}}</div>')
            }
        });
    }
};

module.exports = TypeAheadActions;