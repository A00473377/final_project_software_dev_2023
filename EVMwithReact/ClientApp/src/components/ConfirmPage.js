import React from 'react';
import './ConfirmPage.css';
import 'bootstrap/dist/css/bootstrap.min.css';

const ConfirmedPage = (props) => {
    const { firstName, lastName, appointmentDate, appointmentTime } = props;

    return (
        <div className="container mt-5">
            <div>
                <h1>YOUR APPOINTMENT BOOKING IS COFIRMED!</h1>
                <p>Please note down the details for your convenience.</p>
            </div>

            <div>
                <div className="row">
                    <div className="col-sm-6 name-font">
                        <h3>First Name:</h3>
                        <p>{firstName}</p>
                    </div>
                    <div className="col-sm-6 name-font">
                        <h3>Last Name:</h3>
                        <p>{lastName}</p>
                    </div>
                    <div className="col-sm-6 name-font">
                        <h3>Date:</h3>
                        <p>{appointmentDate}</p>
                    </div>
                    <div className="col-sm-6 name-font">
                        <h3>Time:</h3>
                        <p>{appointmentTime}</p>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default ConfirmedPage;