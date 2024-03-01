import axios from "axios";
import LanguageUtils from "libs/languageUtil";
import { useEffect, useState } from "react";
import { useLocation } from "react-router-dom";
import "../home/HomePageMetaData.css";
import { HomeBanner } from "./banner-component/home-banner";
import { HomeHeader } from "./header-component/home-header";
import { HomeService } from "./service-component/home-service";
interface HomeMetaProp {
  apiUrl: string;
}

export const HomeMetaData: React.FC<HomeMetaProp> = ({ apiUrl }) => {
  const [homeSessionService, setHomeSessionService] = useState();
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);
  const location = useLocation();
  var language = LanguageUtils.loadCurrentLanguage();
  useEffect(() => {
    const populateWeatherData = async () => {
      try {
        const response = await axios.get(apiUrl, {
          headers: {
            Language: language,
          },
        });
        setHomeSessionService(response.data);
        console.log("home page data result: ", response?.data);

        setLoading(false);
      } catch (error) {
        setError("Error fetching data");
        setLoading(false);
      }
    };

    if (apiUrl) {
      populateWeatherData();
    }
  }, []);
  return (
    <>
      {loading && <span className="loader"></span>}
      {error && <p>{error}</p>}
      {homeSessionService && (
        <div>
          <HomeBanner data={homeSessionService} />
          <HomeHeader data={homeSessionService} />
          <HomeService data={homeSessionService} />
        </div>
      )}
    </>
  );
};
