import React, { Component } from 'react';
import { Jumbotron, Button } from 'reactstrap';
import MyNavbar from './navbar/MyNavbar';
import IndexRouter from '../routing/IndexRouter';

class Index extends Component {
  match;
  constructor({match}) {
    super();
    this.match = match;
  }
  render() {
    return (
      <div>
        <MyNavbar currentRoute={this.match}></MyNavbar>
        <div className="homePage">
          <IndexRouter match={this.match}></IndexRouter>
        </div>
      </div>
    );
  }
}

export default Index;
