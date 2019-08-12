import React from "react";
import { Navbar, Nav } from "react-bootstrap";

const Navigation: React.FC = () => (
  <header>
    <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark">
      <Navbar.Brand href="#">FiveRingsOnline</Navbar.Brand>
      <Navbar.Toggle aria-controls="responsive-navbar-nav" />
      <Navbar.Collapse id="responsive-navbar-nav">
        <Nav className="mr-auto">
          <Nav.Link href="#">Decks</Nav.Link>
          <Nav.Link href="#">Find Games</Nav.Link>
        </Nav>
        <Nav>
          <Nav.Link href="#">Login</Nav.Link>
        </Nav>
      </Navbar.Collapse>
    </Navbar>
  </header>
);

export default Navigation;