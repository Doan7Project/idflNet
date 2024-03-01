interface HomeMetaProp {
  data: any;
}
export const HomeHeader: React.FC<HomeMetaProp> = ({ data }) => {
  
  return (
    <>
      <div className="pt-20 space-y-4 text-center m-auto container p-4">
        <h1 className="text-center font-bold md:text-2xl">{data.sessionServices.header}</h1>
        <h4 className="md:text-xl font-light pt-10">{data.sessionServices.subHeader}</h4>
      </div>
    </>
  );
};
