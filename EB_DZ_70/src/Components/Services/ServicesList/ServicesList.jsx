import React from "react";
import { ServicesItem } from "./ServicesItem/ServicesItem";
import icon1 from '../../../Assets/Imgs/services_icon1.png'
import icon2 from '../../../Assets/Imgs/services_icon2.png'
import icon3 from '../../../Assets/Imgs/services_icon3.png'
import icon4 from '../../../Assets/Imgs/services_icon4.png'
import icon5 from '../../../Assets/Imgs/services_icon5.png'
import icon6 from '../../../Assets/Imgs/services_icon6.png'

export const ServicesList = () =>
{
    return (
        <div className="services-list">
            <ServicesItem img={icon1} text={'Construction'}/>
            <ServicesItem img={icon2} text={'Renovation'}/>
            <ServicesItem img={icon3} text={'Consultation'}/>
            <ServicesItem img={icon4} text={'Repair Services'}/>
            <ServicesItem img={icon5} text={'Architecture'}/>
            <ServicesItem img={icon6} text={'Electric'}/>
        </div>
    )
}