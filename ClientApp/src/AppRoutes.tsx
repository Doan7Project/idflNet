import { HOME_META_DATA } from "pathUrl/PathUrl";
import { HomeMetaData } from "components/client/home/HomePageMetaData";

const AppRoutes = [

  {
    index: true,
    element: <HomeMetaData apiUrl = {HOME_META_DATA}/>
  }
];

export default AppRoutes;
