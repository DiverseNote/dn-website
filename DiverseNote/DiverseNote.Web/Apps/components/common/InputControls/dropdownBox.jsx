"use strict";

var React = require('react');

var DropDownBox = React.createClass({
    propTypes: {
        label: React.PropTypes.string.isRequired,
        id: React.PropTypes.string.isRequired,
        items: React.PropTypes.array
    },

    render: function () {

        var dropDownBoxItems = [];
        var inputType = this.props.inputType;
        var id = this.props.id;
        this.props.items.forEach(function (item) {
            dropDownBoxItems.push(<option key={id + item.value} value={item.value }>{item.text}</option>);
            }
        );

        return (
            <fieldset className="form-group">
                <label htmlFor={this.props.id}>{this.props.label}</label>
                <select className="form-control" id={id}>
                  {dropDownBoxItems}
                </select>
              </fieldset>
 );
}
});

module.exports = DropDownBox;