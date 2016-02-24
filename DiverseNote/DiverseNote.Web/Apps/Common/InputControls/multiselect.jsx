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
        var inputType = this.props.inputType;
        var id = this.props.id;
        this.props.items.forEach(function (item) {
            multiselectItems.push(<label className="btn btn-default" key={id + item.value}>
                                    <input type={inputType} autoComplete="off" />{item.text}
                                </label>);
            }
        );

        return (
                     <div className="form-group">
                        <label htmlFor={this.props.id}>{this.props.label}</label>
                      <div className="btn-group btn-group-vertical" role="group" aria-label="vetInput" data-toggle="buttons">
                          {multiselectItems}
                      </div>
                    </div>
 );
    }
});

module.exports = MultiSelect;