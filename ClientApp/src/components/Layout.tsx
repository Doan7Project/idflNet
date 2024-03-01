import React, { Component, ReactNode } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './client/navbar/NavMenu';

interface LayoutProps {
  children: ReactNode;
}

export class Layout extends Component<LayoutProps> {
  static displayName = Layout.name;

  render() {
    return (
      <div>
        <NavMenu />
        <div>
          {this.props.children}
        </div>
      </div>
    );
  }
}

