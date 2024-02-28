import { useEffect, useState } from 'react';
const getWindowReponsive = () => {
  const { innerWidth: width } = window;
  return {
    width
  };
}
export const useWindowReponsive = () => {
  const [windowDimensions, setWindowDimensions] = useState(getWindowReponsive());

  useEffect(() => {
    const handleResize = () => {
      setWindowDimensions(getWindowReponsive());
    }
    window.addEventListener('resize', handleResize);
    return () => window.removeEventListener('resize', handleResize);
  }, []);

  return windowDimensions;
}