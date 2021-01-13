const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const lessonFeedbackModel = new Schema({
    feedbackPostDate: { type: "date", required: true },
    feedbackEditDate: { type: "date", required: true },
    description: { type: String, required: true},
    rating: { type: Number, required: true },
    studentId: { type: mongoose.Types.ObjectId, required: true },
    valuableFeedback: { type: [Schema.Types.ObjectId], required: false },
    notValuableFeedback: { type: [Schema.Types.ObjectId], required: false }
  });

const lessonItemModel = new Schema({
    teacherId: { type: Schema.Types.ObjectId, required: true },
    educationLevel: { type: [String], required: true },
    places: { type: [String], required: true },
    teachingLanguages: { type: [String], required: true },
    hourlyRate: { type: Number, required: true },
    onlineModeEnable: { type: Boolean, required: true },
    faceToFaceModeStudentPlaceEnable: { type: Boolean, required: true },
    faceToFaceModeTeacherPlaceEnable: { type: Boolean, required: true },
    description: { type: String, required: false},
    fieldOfStudy: { type: String, required: true},
    lessonFeedback: { type: [lessonFeedbackModel], required: false },
    numberOfFeedbacks: { type: Number, required: false },
    rating: { type: Number, required: false },
    phoneNumber: { type: String, required: false},
    email: { type: String, required: false},
    firstFreeLessonEnable: { type: Boolean, required: false}
});

module.exports = mongoose.model('lessonItem', lessonItemModel);
