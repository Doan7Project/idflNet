import axios from "axios";
import { useEffect, useState } from "react";

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
  console.log("home page data result: ", homeSessionService?.header);
  useEffect(() => {
    const populateWeatherData = async () => {
      try {
        const response = await axios.get(apiUrl);
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
  }, [apiUrl]);
  return (
    <>
      {loading && (
        <div className="spinner-border m-5" role="status">
          <span className="visually-hidden">Loading...</span>
        </div>
      )}
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
