<<<<<<< Updated upstream
﻿namespace Domain.Dto.Out
{
    public class InterviewInfoOutDto
    {
        public string FullNameInterviewer { get; set; }
        public string FullIdInterviewer { get; set; }
=======
﻿using System.Text.Json.Serialization;

namespace Domain.Dto.In
{
    public class InterviewInfoOutDto
    {
        public object InterviewTime;
        public object InterviewModality;
        public object InterviewType;
        public object InterviewCity;
        public object InterviewResultCode;

        [JsonPropertyName("interviewCountry")]
        public string InterviewCountry { get; set; }

        [JsonPropertyName("interviewDepartment")]
        public string InterviewDepartment { get; set; }

        [JsonPropertyName("interviewMunicipality")]
        public string InterviewMunicipality { get; set; }

        [JsonPropertyName("interviewDate")]
>>>>>>> Stashed changes
        public string InterviewDate { get; set; }

        [JsonPropertyName("interviewPlace")]
        public string InterviewPlace { get; set; }
<<<<<<< Updated upstream
        public string InterviewCountry { get; set; }
        public string InterviewDepartment { get; set; }
        public string InterviewCity { get; set; }
        public string InterviewResultCode { get; set; }
=======

        [JsonPropertyName("interviewResult")]
        public string InterviewResult { get; set; }

        [JsonPropertyName("interviewerName")]
        public string InterviewerName { get; set; }

        [JsonPropertyName("interviewerPosition")]
        public string InterviewerPosition { get; set; }
>>>>>>> Stashed changes
    }
}
