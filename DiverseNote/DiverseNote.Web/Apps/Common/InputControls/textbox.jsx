"use strict";

var React = require('react');

var TextBox = React.createClass({
    propTypes: {
        label: React.PropTypes.string.isRequired,
        inputType: React.PropTypes.string.isRequired,
        id: React.PropTypes.string.isRequired,
        placeholder: React.PropTypes.string
    },

    render: function () {
        return (
                    <div className="form-group">
                        <label htmlFor={this.props.id}>{this.props.label}</label>
                        <input type={this.props.inputType} className="form-control" id={this.props.id} placeholder={this.props.placeholder} />
                    </div>
 );
    }
});

module.exports = TextBox;