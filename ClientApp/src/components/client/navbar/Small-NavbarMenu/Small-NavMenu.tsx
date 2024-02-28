import React, { useEffect, useState } from "react";
import "./Small-NavMenu.css";
import LanguageUtils from "libs/languageUtil";
const SmallNavbarMenu: React.FC<{}> = () => {
  const [activeToggle, setActiveToggle] = useState("");
  const [toggle, setToggle] = useState(false);
  const [buggerOne, setBuggerOne] = useState("");
  const [buggerTwo, setBuggerTwo] = useState("");
  const [isActive, setIsActive] = useState("");
  const [dropDownList, setDropDownList] = useState("");
  const [dropDownListLanguage, setDropDownListLanguage] = useState("");
  const [languageLable, setLanguageLable] = useState(false);

  const activeToggleClick = () => {
    setActiveToggle(toggle ? "" : "activeToggleBugger");
    setIsActive(toggle ? "" : "isActive");
    setBuggerOne(toggle ? "" : "small-navbar-container_bugger-line-x-1");
    setBuggerTwo(toggle ? "" : "small-navbar-container_bugger-line-x-2");
    setToggle(!toggle);
  };
  const DropDownClick = () => {
    setDropDownList(toggle ? "" : "activeDropDownList");
    setToggle(!toggle);
  };
  const DropDownLanguageClick = () => {
    setDropDownListLanguage(toggle ? "" : "activeDropDownList");
    setToggle(!toggle);
  };
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
    <nav className="small-navbar-container flex justify-between items-center p-8">
      <div className="small-navbar-container_icon flex justify-center items-center space-x-4">
        <img src="/icons/idfl-icon.png" alt="" />
        <a href="#" className="text-white">
          IDFL VIETNAM
        </a>
      </div>
      <div
        className="small-navbar-container_bugger"
        onClick={() => activeToggleClick()}
      >
        <div
          className={`small-navbar-container_bugger-line-1 ${buggerOne}`}
        ></div>
        <div
          className={`small-navbar-container_bugger-line-2 ${isActive}`}
        ></div>
        <div
          className={`small-navbar-container_bugger-line-3 ${buggerTwo}`}
        ></div>
      </div>
      <div
        className={`small-navbar-container_bugger-navigator ${activeToggle}`}
      >
        <ul className="small-navbar-container_bugger-navigator_dropdownlist-container space-y-4">
          <li>
            <a href="">Trang chủ</a>
          </li>
          <li onClick={() => DropDownClick()}>
            <div className="flex space-x-2 cursor-pointer">
              <span>Dịch vụ</span>
              <img className="pt-1" src="/icons/Polygon.svg" alt="" />
            </div>
            <div
              className={`small-navbar-container_bugger-navigator_dropdownlist space-y-2 ${dropDownList}`}
            >
              <div>
                <a href="">Audits & Certifications</a>
              </div>
              <div>
                <a href="">Labboratory</a>
              </div>
              <div>
                <a href="">Inspection</a>
              </div>
            </div>
          </li>
          <li>
            <a href="">Về chúng tôi</a>
          </li>
          <li onClick={() => DropDownLanguageClick()}>
            <div className="flex space-x-2 cursor-pointer">
              {!languageLable && (
                <>
                  <img
                    className="navbar-flat-icon w-5"
                    src="/icons/vietnam.png"
                    alt="vietnam"
                  />
                  <span>VI</span>
                </>
              )}
              {languageLable && (
                <>
                  <img
                    className="navbar-flat-icon w-5"
                    src="/icons/english.png"
                    alt="vietnam"
                  />
                  <span>EN</span>
                </>
              )}
              <img className="pt-1" src="/icons/Polygon.svg" alt="" />
            </div>
            <div
              className={`small-navbar-container_bugger-navigator_dropdownlist space-y-3 ${dropDownListLanguage}`}
            >
              <div className="space-x-2">
                <a href="" onClick={() => handleLanguageChange("vi")}>Vietnam</a>
              </div>
              <div className="space-x-2">
                <a href="" onClick={() => handleLanguageChange("en")}>English</a>
              </div>
            </div>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default SmallNavbarMenu;
