var alt = require('../alt');

class CandidateActions {
    addCandidate(candidate) {
        return candidate;
    }
}

module.exports = alt.createActions(CandidateActions);