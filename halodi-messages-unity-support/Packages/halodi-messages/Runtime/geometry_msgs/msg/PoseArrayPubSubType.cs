using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "PoseArray" defined in "PoseArray.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from PoseArray.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit PoseArray.idl instead.
*
*/
public class PoseArrayPubSubType : Halodi.CDR.TopicDataType<geometry_msgs.msg.PoseArray>
{
   public override string Name => "geometry_msgs::msg::dds_::PoseArray_";


   
   public override void serialize(geometry_msgs.msg.PoseArray data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.PoseArray data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.PoseArray data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.PoseArray data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.poses.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.PosePubSubType.getCdrSerializedSize(data.poses[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.PoseArray data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      	if(data.poses == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int poses_length = data.poses.Count;
            cdr.write_type_2(poses_length);
            for (int i0 = 0; i0 < poses_length; i0++)
            {
      			geometry_msgs.msg.PosePubSubType.write(data.poses[i0], cdr);	      }
        }
   }

   public static void read(geometry_msgs.msg.PoseArray data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int poses_length = cdr.read_type_2();
      data.poses = new System.Collections.Generic.List<geometry_msgs.msg.Pose>(poses_length);
      for(int i = 0; i < poses_length; i++)
      {
      	geometry_msgs.msg.Pose new_poses = geometry_msgs.msg.PosePubSubType.Create(); 
      	geometry_msgs.msg.PosePubSubType.read(new_poses, cdr);
      	data.poses.Add(new_poses);	
      	
      }

      	

   }


    public static void Copy(geometry_msgs.msg.PoseArray src, geometry_msgs.msg.PoseArray target)
    {
        target.Set(src);
    }


}


}