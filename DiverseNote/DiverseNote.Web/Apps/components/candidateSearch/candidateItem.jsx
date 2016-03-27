"use strict";

var React = require('react');
var Button = require('../common/InputControls/button.jsx');

var CandidateItem = React.createClass({
    render: function () {
        return (
            <div className="blockItem list-group">
                    <div className="list-group-item">                        
                        <table className="search-item-content">
                            <tbody>
                        <tr>
                            <td className="search-item-label">
                                <a href="#" className="candidate-name-header"><h3 className="search-item-title">{this.props.candidate.FirstName + " " + this.props.candidate.LastName}</h3></a>
                            </td>
                            <td>
                                 <span className="pull-right">
                                      <button className="btn btn-xs btn-warning search-item-option">
                                        <span className="glyphicon glyphicon-envelope"></span>
                                      </button>
                                    <a href="" className="search-item-option">
                                    <span className="glyphicon glyphicon-star-empty"></span>
                                    </a>
                                    <span className="glyphicon glyphicon-eye-open search-item-option" alt="viewed"></span>
                                 </span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div><span className="listItemLabel">About</span> {this.props.candidate.Description} <a href="#">View More</a></div>
                                    <div><span className="listItemLabel">Skills</span> {this.props.skills}</div>
                                </td>
                                </tr>
                          </tbody>
                        </table>
                    </div>
                </div>
        );
    }
});

module.exports = CandidateItem;