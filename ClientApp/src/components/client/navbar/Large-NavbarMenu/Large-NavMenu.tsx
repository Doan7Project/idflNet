import React, { useEffect, useState } from "react";
import "./Large-NavMenu.css";
import LanguageUtils from "libs/languageUtil";
interface LargeNavbarMenuProps {}

const LargeNavbarMenu: React.FC<{}> = () => {
  const [languageLable, setLanguageLable] = useState(false);

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
  return (
    <nav className="navbar-container flex justify-between items-center px-20 py-6">
      <div className="navbar-container_icon flex justify-center items-center space-x-4">
        <img src="/icons/idfl-icon.png" alt="" />
        <a href="#" className="text-white">
          IDFL VIETNAM
        </a>
      </div>
      <div>
        <ul className="flex justify-center items-center space-x-6 navbar-container_route">
          <li className=" p-2">
            <a className="navbar-container_route-navigator" href="">
              Trang chủ
            </a>
          </li>
          <li className="flex space-x-2 navbar-container_dropdown-container p-2">
            <span className="navbar-container_route-navigator navbar-container_route-navigator-service">
              Dịch vụ
            </span>
            <img className="pt-1" src="/icons/Polygon.svg" alt="" />
            <div className="navbar-container_dropdown-list shadow-sm">
              <ul className="space-y-3">
                <li>
                  <a href="">Audits & Certifications</a>
                </li>
                <li>
                  <a href="">Labboratory</a>
                </li>
                <li>
                  <a href="">Inspection</a>
                </li>
              </ul>
            </div>
          </li>
          <li className="navbar-container_route-navigator p-2">Về chúng tôi</li>
        </ul>
      </div>
      <div>
        <ul className="flex justify-center items-center space-x-6">
          <li className="navbar-container_route-navigator">Đăng nhập</li>
          <li className="flex space-x-2 navbar-container_dropdown-container p-2">
            {!languageLable && (
              <img
                className="navbar-flat-icon w-5 navbar-container_route-navigator navbar-container_route-navigator-service"
                src="/icons/vietnam.png"
                alt="vietnam"
              />
            )}
            {languageLable && (
              <img
                className="navbar-flat-icon w-5 navbar-container_route-navigator navbar-container_route-navigator-service"
                src="/icons/english.png"
                alt="vietnam"
              />
            )}
            <img className="pt-1" src="/icons/Polygon.svg" alt="" />
            <div className="navbar-container_dropdown-list_language shadow-sm">
              <ul className="space-y-3">
                <li>
                  <a href="" onClick={()=> handleLanguageChange("vi")}>Vietnam</a>
                </li>
                <li>
                  <a href="" onClick={()=> handleLanguageChange("en")}>English</a>
                </li>
              </ul>
            </div>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default LargeNavbarMenu;
