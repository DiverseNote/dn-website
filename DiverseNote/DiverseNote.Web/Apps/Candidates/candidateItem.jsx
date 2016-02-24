"use strict";

var React = require('react');
var CandidateItem = React.createClass({
    render: function () {
        return (
                <div className="list-group blockItem">
                    <div className="list-group-item">                        
                        <table>
                        <tr>
                            <td className="profile-image"><img className="img-responsive img-circle" height="100" width="90" src="../../../Images/Candidates/candidateHeadshot.png" /></td>
                            <td>
                                <h3>{this.props.candidate.name}</h3>
                                <div>{this.props.candidate.title}</div>
                                <div><span className="listItemLabel">Salary</span> {this.props.candidate.salary} <span className="listItemLabel"> Skills</span> {this.props.candidate.skills}</div>
                            </td>
                        </tr>
                        </table>
                                               
                    </div>
                </div>
            )
    }
});

module.exports = CandidateItem;