const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const userContactDataModel = new Schema({
  phone: new Schema(
    {number: {type: String, required: false},
    visible: {type: Boolean, required: false}
  }),
  email: new Schema(
    {email: {type: String, required: false},
    visible: {type: Boolean, required: false}
  }),
  photo: { type: String, required: false },
  firstFreeLessonEnable: {type: Boolean, required: false},
  description: { type: String, required: false }
});


const userModel = new Schema({
  firstName: { type: String, required: true },
  lastName: { type: String, required: true },
  email: { type: String, required: true },
  phone: { type: String, required: false },
  password: { type: String, required: true },
  dateOfBirth: { type: "date", required: true },
  educationLevel: { type: String, required: true },
  gender: { type: String, required: false },
  registered: { type: "date", required: true },
  status: { type: String, required: true, default: 'active' },
  contactInfo: { type: userContactDataModel, required: false },

  role: { type: String, required: true, default: 'user' },
  bio: { type: String, required: false }
});

module.exports = mongoose.model('user', userModel);
