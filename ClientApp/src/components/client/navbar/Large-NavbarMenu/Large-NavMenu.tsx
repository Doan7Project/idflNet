import React from "react";

interface LargeNavbarMenuProps {}

const LargeNavbarMenu: React.FC<{}> = () => {
  return (
    <nav className="bg-sky-500 navbar-container flex justify-between items-center p-8 text-white">
      <div>
        <label htmlFor="">LOGO IDFL</label>
      </div>
      <div>
        <ul className="flex justify-center items-center space-x-4">
          <li>Home</li>
          <li>Services</li>
          <li>About</li>
        </ul>
      </div>
      <div>
        <ul className="flex justify-center items-center space-x-4">
          <li>Login</li>
          <li>Language</li>
        </ul>
      </div>
    </nav>
  );
};

export default LargeNavbarMenu;
