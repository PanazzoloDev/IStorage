import styled from "styled-components";

interface filterPanelContainerProps {
    open: boolean;
}

const FilterPanelContainer = styled.div<filterPanelContainerProps>`
    height: 100vh;
    background-color: #eb3f24;
    width: ${props => props.open? '300px' : '50px'};
    max-width: 50vw;
`

export {
    FilterPanelContainer,
}