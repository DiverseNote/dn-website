"use strict";

var React = require('react');
var TypeAheadAction = require('typeaheadaction');

var TextBox = React.createClass({
    propTypes: {
        label: React.PropTypes.string.isRequired,
        inputType: React.PropTypes.string.isRequired,
        id: React.PropTypes.string.isRequired,
        suggestionsource: React.PropTypes.string.isRequired,
        propname: React.PropTypes.string,//the name of the property to bind to
        placeholder: React.PropTypes.string,
        value: React.PropTypes.string,
        onchange: React.PropTypes.func
    },

    render: function () {
        return (
                    <div className="form-group">
                        <label htmlFor={this.props.id}>{this.props.label}</label>
                        <div id={this.props.id}>
                            <input type={this.props.inputType} name={this.props.propname} onChange={this.props.onchange} value={this.props.value} className="form-control typeahead" placeholder={this.props.placeholder} />
                        </div>
                    </div>
 );
    }
});

module.exports = TextBox;