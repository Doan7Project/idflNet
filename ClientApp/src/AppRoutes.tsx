import { HOME_META_DATA } from "pathUrl/PathUrl";
import { FetchData } from "./components/client/home/FetchData";

const AppRoutes = [

  {
    index: true,
    element: <FetchData apiUrl = {HOME_META_DATA}/>
  }
];

export default AppRoutes;
