import React, { useRef, useState } from "react";
// Import Swiper React components
import { Swiper, SwiperSlide } from "swiper/react";

// Import Swiper styles
import "swiper/css";
import "swiper/css/navigation";
import "swiper/css/pagination";
// import required modules
import { A11y, Autoplay, Navigation, Pagination } from "swiper/modules";

interface HomeMetaProp {
  data: any;
}
export const HomeBanner: React.FC<HomeMetaProp> = ({ data }) => {
  console.log(data.sessionBanners);
  return (
    <>
      <Swiper
        spaceBetween={30}
        centeredSlides={true}
        autoplay={{
          delay: 4500,
          disableOnInteraction: false,
        }}
        pagination={{
          clickable: true,
        }}
        modules={[Autoplay, Pagination, A11y]}
        className="mySwiper"
      >
        {data.sessionBanners.map((banner: any, index:any) => (
          <SwiperSlide key={index}>
            <img key={banner.id} src={banner.url} alt="Banner Thumbnail" />
          </SwiperSlide>
        ))}
      </Swiper>
    </>
  );
};
