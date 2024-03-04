import React from "react";
import '../../Assets/Components/advantages.scss'
import { AdvantageItem } from "./AdvantageItem/AdvantageItem";
import icon1 from '../../Assets/Imgs/icon1.png';
import icon2 from '../../Assets/Imgs/icon2.png';

export const Advantages = () =>
{
    return (
        <div className="advantages-wrapper">
            <div className="advantages-header">Our Reputation</div>
            <div className="advantage-list">
                <AdvantageItem
                    img={icon1} 
                    title={'Best Services'} 
                    description={'Nullam senectus porttitor in eget. Eget rutrum leo interdum.'}
                />
                <AdvantageItem
                    img={icon1} 
                    title={'Best Teams'} 
                    description={'Cursus semper tellus volutpat aliquet lacus.'}
                />
                <AdvantageItem
                    img={icon2}
                    title={'Best Designs'} 
                    description={'Ultricies at ipsum nunc, tristique nam lectus.'}
                />
            </div>
            
        </div>
    )
}