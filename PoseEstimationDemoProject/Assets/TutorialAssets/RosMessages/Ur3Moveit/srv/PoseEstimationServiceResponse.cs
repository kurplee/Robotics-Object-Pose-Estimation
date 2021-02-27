//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Ur3Moveit
{
    public class PoseEstimationServiceResponse : Message
    {
        public const string RosMessageName = "ur3_moveit/PoseEstimationService";

        public Geometry.Pose estimated_pose;

        public PoseEstimationServiceResponse()
        {
            this.estimated_pose = new Geometry.Pose();
        }

        public PoseEstimationServiceResponse(Geometry.Pose estimated_pose)
        {
            this.estimated_pose = estimated_pose;
        }
        public override List<byte[]> SerializationStatements()
        {
            var listOfSerializations = new List<byte[]>();
            listOfSerializations.AddRange(estimated_pose.SerializationStatements());

            return listOfSerializations;
        }

        public override int Deserialize(byte[] data, int offset)
        {
            offset = this.estimated_pose.Deserialize(data, offset);

            return offset;
        }

        public override string ToString()
        {
            return "PoseEstimationServiceResponse: " +
            "\nestimated_pose: " + estimated_pose.ToString();
        }
    }
}