import React from "react";
import { ProjectItem } from "./ProjectItem/ProjectItem";
import project1 from '../../../../Assets/Imgs/project1.jpg';
import project2 from '../../../../Assets/Imgs/project2.jpg';
import project3 from '../../../../Assets/Imgs/project3.jpg';
import project4 from '../../../../Assets/Imgs/project4.jpg';

export const ProjectsList = () =>
{
    return (
        <ol className="projects-list">
            <ProjectItem img={project1} name={'Wildstone Infra Hotel'} address={'2715 Ash Dr. San Jose, South Dakota'}/>
            <ProjectItem img={project2} name={'Wish Stone Building'} address={'2972 Westheimer Rd. Santa Ana, Illinois '}/>
            <ProjectItem img={project3} name={'Mr. Parkinston’s House'} address={'3517 W. Gray St. Utica, Pennsylvania'}/>
            <ProjectItem img={project4} name={'Oregano Height'} address={'2464 Royal Ln. Mesa, New Jersey '}/>
        </ol>
    )
}