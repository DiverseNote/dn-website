"use strict";

var React = require('react');
var CheckBoxList = require('react-checkbox-list');

var MultiSelect = React.createClass({
    propTypes: {
        label: React.PropTypes.string,
        inputType: React.PropTypes.string,
        id: React.PropTypes.string.isRequired,
        items: React.PropTypes.array,
        onchange: React.PropTypes.func,
        propname: React.PropTypes.string
    },

    render: function () {
        
        var id = this.props.id;
        return (       
                <fieldset className="form-group">
                <label htmlFor={id}>{this.props.label}</label>
			        <CheckBoxList ref={id} name={this.props.propname} defaultData={this.props.items} onChange={this.props.onchange} />
                </fieldset>
 );
    }
});

module.exports = MultiSelect;