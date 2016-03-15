"use strict";

var React = require('react');

var MultiSelect = React.createClass({
    propTypes: {
        label: React.PropTypes.string.isRequired,
        inputType: React.PropTypes.string.isRequired,
        id: React.PropTypes.string.isRequired,
        items: React.PropTypes.array
    },

    render: function () {

        var multiselectItems = [];
        var id = this.props.id;
        var inputType = this.props.inputType;
        this.props.items.forEach(function (item) {
            multiselectItems.push(<div className="checkbox" key={id + item.value}><label><input type="checkbox" value={item.value} />{item.text}</label></div>);
            }
        );

        return (       
                <fieldset className="form-group">
                <label htmlFor={this.props.id}>{this.props.label}</label>
                    {multiselectItems}
                </fieldset>
 );
    }
});

module.exports = MultiSelect;