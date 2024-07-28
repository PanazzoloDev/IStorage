import styled from "styled-components";

const CardContainer = styled.div`
    width: 200px;
    height: 250px;
    border-radius: 15px;
    box-shadow: 5px 5px 8px 8px rgba(0, 0, 0, 0.3);
    display: flex;
    flex-direction: column;
    margin: 20px;
    color: black;
    transition: 1s;
    &:hover,:focus{
        transform: scale(1.05)
    }
`
const CardImage = styled.img`
    height: 80%;
    max-height: 150px;
    padding: 0px;
    border-radius: 15px 15px 0px 0px;
    transition: 1s;
`
const CardValues = styled.div`
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: start;
`
interface CardValueProps {
    discount: boolean;
}

const CardValue = styled.span<CardValueProps>`
    width: 100%;
    ${props => props.discount ? 
        'background-color: orange;' : ''};
    font-weight: bold;
    font-size: 25px;
    align-self: center;
`

export {
    CardContainer,
    CardImage,
    CardValues,
    CardValue
};
