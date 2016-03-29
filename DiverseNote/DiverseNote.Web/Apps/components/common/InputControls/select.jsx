"use strict";

var React = require('react');

var Select = React.createClass({
    propTypes: {
        label: React.PropTypes.string,
        inputType: React.PropTypes.string,
        id: React.PropTypes.string.isRequired,
        value: React.PropTypes.string.isRequired
    },

    render: function () {
        return (
        <fieldset className="form-group">
            <div className="checkbox">
                <label><input type="checkbox" value={this.props.value } />{this.props.label}</label>
            </div>
</fieldset>
 );
}
});

module.exports = Select;