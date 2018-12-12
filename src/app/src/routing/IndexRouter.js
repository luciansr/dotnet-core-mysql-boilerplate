import React from "react";
import { HashRouter as Router, Route, Link, Redirect } from "react-router-dom";

import Page1 from '../index/components/page1/Page1';
import Page2 from '../index/components/page2/Page2';
import Home from '../index/components/home/Home';

const IndexRouter = ({ match }) => (
  <Router>
    <div>
        {
            console.log(match)
        }
      <Route exact path={match.path} component={Home} />
      <Route path={`${match.url}/page1`} component={Page1} />
      <Route path={`${match.url}/page2`} component={Page2} />
    </div>
  </Router>
);

export default IndexRouter;
