import { useState } from "react";

import "./CVForm.css";

const CVForm = ({ onSave, disabled, applicant, onCancel }) => {
    const [name, setName] = useState(applicant?.name ?? "");
    const [birthDate, setBirthDate] = useState(applicant?.birthDate ?? "");
    const [email, setEmail] = useState(applicant?.email ?? "");
    const [telephoneNumber, setTelephoneNumber] = useState(applicant?.telephoneNumber ?? "");
    const [location, setLocation] = useState(applicant?.location ?? "");
    const [level, setLevel] = useState(applicant?.level ?? "");
    const [category, setCategory] = useState(applicant?.category ?? "");
    const [education, setEducation] = useState(applicant?.education ?? "");
    const [description, setDescription] = useState(applicant?.description ?? "");
    const [isActive, setIsActive] = useState(applicant?.isActive ?? false);
  
    const onSubmit = (e) => {
      e.preventDefault();
  
      if (applicant) {
        return onSave({
          ...applicant,
          name,
          birthDate,
          email,
          telephoneNumber,
          location,
          level,
          category,
          education,
          description,
          isActive,
        });
      }
  
      return onSave({
        name,
        birthDate,
        email,
        telephoneNumber,
        location,
        level,
        category,
        education,
        description,
        isActive,
      });
    };

    return (
        <form className="CVForm" onSubmit={onSubmit}>
          <div className="control">
            <label htmlFor="name">Name:</label>
            <input
              value={name}
              onChange={(e) => setName(e.target.value)}
              name="name"
              id="name"
            />
          </div>
    
          <div className="control">
            <label htmlFor="birthDate">Birthdate:</label>
            <input
              value={birthDate}
              onChange={(e) => setBirthDate(e.target.value)}
              name="birthDate"
              id="birthDate"
            />
          </div>
    
          <div className="control">
            <label htmlFor="email">Email:</label>
            <input
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              name="email"
              id="email"
            />
          </div>

          <div className="control">
            <label htmlFor="telephoneNumber">Telephone number:</label>
            <input
              value={telephoneNumber}
              onChange={(e) => setTelephoneNumber(e.target.value)}
              name="telephoneNumber"
              id="telephoneNumber"
            />
          </div>

          <div className="control">
            <label htmlFor="location">Location:</label>
            <input
              value={location}
              onChange={(e) => setLocation(e.target.value)}
              name="location"
              id="location"
            />
          </div>

          <div className="control">
            <label htmlFor="level">Level:</label>
            <input
              value={level}
              onChange={(e) => setLevel(e.target.value)}
              name="level"
              id="level"
            />
          </div>

          <div className="control">
            <label htmlFor="category">Category:</label>
            <input
              value={category}
              onChange={(e) => setCategory(e.target.value)}
              name="category"
              id="category"
            />
          </div>

          <div className="control">
            <label htmlFor="education">Education:</label>
            <input
              value={education}
              onChange={(e) => setEducation(e.target.value)}
              name="education"
              id="education"
            />
          </div>

          <div className="control">
            <label htmlFor="description">Description:</label>
            <input
              value={description}
              onChange={(e) => setDescription(e.target.value)}
              name="description"
              id="description"
            />
          </div>

          <div className="control">
            <label htmlFor="isActive">Active:</label>
            <input
              type="checkbox"
              checked={isActive}
              onChange={(e) => setIsActive(e.target.checked)}
              name="isActive"
              id="isActive"
            />
          </div>
          <div className="button-container">
            <button type="submit" disabled={disabled}>
              {applicant ? "Update CV" : "Create CV"}
            </button>
    
            <button type="button" onClick={onCancel}>
              Cancel
            </button>
          </div>
        </form>
      );
    };
    
    export default CVForm;
    