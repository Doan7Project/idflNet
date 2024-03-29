import React, { useEffect, useState } from "react";
import {
  Collapse,
  Dropdown,
  DropdownItem,
  DropdownMenu,
  DropdownToggle,
  Navbar,
  NavbarBrand,
  NavbarToggler,
  NavItem,
  NavLink,
} from "reactstrap";
import { Link } from "react-router-dom";
import LanguageUtils from "libs/languageUtil";
import LargeNavbarMenu from "./Large-NavbarMenu/Large-NavMenu";
import SmallNavbarMenu from "./Small-NavbarMenu/Small-NavMenu";
import { useWindowReponsive } from "../../../hooks/useWindowReponsive";
import { WIDTH } from "constants/common.constant";
export const NavMenu: React.FC<{}> = () => {
  const [collapsed, setCollapsed] = useState<boolean>(true);
  const [isOpen, setIsOpen] = useState<boolean>(false);
  const [languageLable, setLanguageLable] = useState(false);
  const toggleNavbar = () => setCollapsed(!collapsed);
  const toggleDropdown = () => setIsOpen(!isOpen);
  const {width} = useWindowReponsive();

  const handleLanguageChange = (language: any) => {
    LanguageUtils.save(language, "");
  };
  useEffect(() => {
    var languageLable = LanguageUtils.loadCurrentLanguage();
    if (languageLable === "vi") {
      setLanguageLable(false);
    } else {
      setLanguageLable(true);
    }
  }, []);

  const [isMenuOpen, setIsMenuOpen] = useState(false);

  const toggleMenu = () => {
    setIsMenuOpen(!isMenuOpen);
  };
  
  return (
    <header>
      {width <= WIDTH ?  <SmallNavbarMenu/> : <LargeNavbarMenu/>}
      {/* <LargeNavbarMenu/> */}
    

      {/* 
      <Navbar
        className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3"
        container
        primary
      >
        <NavbarBrand tag={Link} to="/">
          idflNet
        </NavbarBrand>
        <NavbarToggler onClick={toggleNavbar} className="mr-2" />
        <Collapse
          className="d-sm-inline-flex flex-sm-row-reverse"
          isOpen={!collapsed}
          navbar
        >
          <ul className="navbar-nav flex-grow">
            <NavItem>
              <NavLink tag={Link} className="text-dark" to="/">
                Home
              </NavLink>
            </NavItem>
            <Dropdown isOpen={isOpen} toggle={toggleDropdown}>
              <DropdownToggle caret>
                {!languageLable && (
                  <img
                    className="navbar-flat-icon"
                    src="/icons/vietnam.png"
                    alt="vietnam"
                  />
                )}
                {languageLable && (
                  <img
                    className="navbar-flat-icon"
                    src="/icons/english.png"
                    alt="vietnam"
                  />
                )}
              </DropdownToggle>
              <DropdownMenu>
                <DropdownItem onClick={() => handleLanguageChange("vi")}>
                  Vietnam
                </DropdownItem>
                <DropdownItem onClick={() => handleLanguageChange("en")}>
                  English
                </DropdownItem>
              </DropdownMenu>
            </Dropdown>
          </ul>
        </Collapse>
      </Navbar> */}
    </header>
  );
};


