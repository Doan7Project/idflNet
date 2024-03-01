interface HomeMetaProp {
  data: any;
}
export const HomeService: React.FC<HomeMetaProp> = ({ data }) => {
  console.log(data.sessionServiceStandard);
  return (
    <div className="pt-20">
      {data.sessionServiceStandard.map((value: any, index: any) => (
        <div key={index} className="relative">
          <img className="w-full" src={value.url} alt="service_image" />
          <div className="w-60 h-20 bg-slate-50 absolute top-0 right-0 flex p-3">
            {value.icons.map((value: any, index: any) => (
              <img key={index} className="w-full" src={value.icons} alt="image_icon" />
            ))}
          </div>
        </div>
      ))}
    </div>
  );
};
