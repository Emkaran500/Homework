import React from "react";
import { AboutUsImg } from "./AboutUsImg/AboutUsImg";
import { AboutUsText } from "./AboutUsText/AboutUsText";
import '../../Assets/Components/aboutus.scss';

export const AboutUs = () =>
{
    return (
        <div className="aboutus-wrapper">
            <AboutUsImg/>
            <AboutUsText/>
        </div>
    )
}