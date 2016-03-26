"use strict";

var React = require('react');
var Button = require('../common/InputControls/button.jsx');

var CandidateItem = React.createClass({
    render: function () {
        return (
            <div className="list-group blockItem">
                    <div className="list-group-item">                        
                        <table>
                        <tr>
                            <td>
                                <h3 className="search-item-title">{this.props.candidate.FirstName + " " + this.props.candidate.LastName}</h3>
                                <div>{this.props.candidate.Description} <a href="#">View More</a></div>
                                <div><span className="listItemLabel"> Skills</span> {this.props.skills}</div>
                            </td>
                            <span className="pull-right">
                              <button className="btn btn-xs btn-warning search-item-option">
                                <span className="glyphicon glyphicon-envelope"></span>
                              </button>
                            </span>
                        </tr>
                        </table>
                                               
                    </div>
                </div>
        );
    }
});

module.exports = CandidateItem;