import React, { Component } from 'react';
import { Jumbotron, Button } from 'reactstrap';

class Page1 extends Component {
  render() {
    return (
        <div className="page1">
            <Jumbotron>
                <h1 className="display-3">Hello, world! Page 1!</h1>
                <p className="lead">This is a simple hero unit, a simple Jumbotron-style component for calling extra attention to featured content or information.</p>
                <hr className="my-2" />
                <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
                <p className="lead">
                <Button color="primary">Learn More</Button>
                </p>
            </Jumbotron>
        </div>
    );
  }
}

export default Page1;
