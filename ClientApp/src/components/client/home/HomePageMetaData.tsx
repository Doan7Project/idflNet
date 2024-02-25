import axios from "axios";
import LanguageUtils from "libs/languageUtil";
import { useEffect, useState } from "react";
import { useLocation } from "react-router-dom";
import "../home/HomePageMetaData.css";
interface HomeMetaProp {
  apiUrl: string;
}
interface SessionServiceResult {
  header: string;
  subHeader: string;
}
export const HomeMetaData: React.FC<HomeMetaProp> = ({ apiUrl }) => {
  const [homeSessionService, setHomeSessionService] =
    useState<SessionServiceResult | null>(null);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);
  const location = useLocation();
  console.log("home page data result: ", homeSessionService?.header);
  var language = LanguageUtils.loadCurrentLanguage();
  useEffect(() => {
    const populateWeatherData = async () => {
      try {
        const response = await axios.get(apiUrl, {
          headers: {
            Language: language,
          },
        });
        setHomeSessionService(response.data.sessionServiceResult);
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
          <h1>{homeSessionService.header}</h1>
          <h4>{homeSessionService.subHeader}</h4>
        </div>
      )}
    </>
  );
};
