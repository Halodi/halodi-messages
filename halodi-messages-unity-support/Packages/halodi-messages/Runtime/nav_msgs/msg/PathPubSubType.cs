using System.IO;
namespace nav_msgs.msg
{

/**
* 
* Topic data type of the struct "Path" defined in "Path.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Path.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Path.idl instead.
*
*/
public class PathPubSubType : Halodi.CDR.TopicDataType<Path>
{
   public override string Name => "nav_msgs::msg::dds_::Path_";


   
   public override void serialize(nav_msgs.msg.Path data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, nav_msgs.msg.Path data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(nav_msgs.msg.Path data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(nav_msgs.msg.Path data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.poses.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.PoseStampedPubSubType.getCdrSerializedSize(data.poses[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(nav_msgs.msg.Path data, Halodi.CDR.CDRSerializer cdr)
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
      			geometry_msgs.msg.PoseStampedPubSubType.write(data.poses[i0], cdr);	      }
        }
   }

   public static void read(nav_msgs.msg.Path data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int poses_length = cdr.read_type_2();
      data.poses = new System.Collections.Generic.List<geometry_msgs.msg.PoseStamped>(poses_length);
      for(int i = 0; i < poses_length; i++)
      {
      	geometry_msgs.msg.PoseStamped new_poses = geometry_msgs.msg.PoseStampedPubSubType.Create(); 
      	geometry_msgs.msg.PoseStampedPubSubType.read(new_poses, cdr);
      	data.poses.Add(new_poses);	
      	
      }

      	

   }


    public static void Copy(nav_msgs.msg.Path src, nav_msgs.msg.Path target)
    {
        target.Set(src);
    }


}


}