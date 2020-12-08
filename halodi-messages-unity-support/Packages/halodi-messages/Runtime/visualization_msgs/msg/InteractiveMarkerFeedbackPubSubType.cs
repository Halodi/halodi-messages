using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "InteractiveMarkerFeedback" defined in "InteractiveMarkerFeedback.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from InteractiveMarkerFeedback.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit InteractiveMarkerFeedback.idl instead.
*
*/
public class InteractiveMarkerFeedbackPubSubType : Halodi.CDR.TopicDataType<InteractiveMarkerFeedback>
{
   public override string Name => "visualization_msgs::msg::dds_::InteractiveMarkerFeedback_";


   
   public override void serialize(visualization_msgs.msg.InteractiveMarkerFeedback data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, visualization_msgs.msg.InteractiveMarkerFeedback data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerFeedback data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.InteractiveMarkerFeedback data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.client_id.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.marker_name.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.control_name.Length + 1;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += geometry_msgs.msg.PosePubSubType.getCdrSerializedSize(data.pose, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += geometry_msgs.msg.PointPubSubType.getCdrSerializedSize(data.mouse_point, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.InteractiveMarkerFeedback data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_d(data.client_id);

      cdr.write_type_d(data.marker_name);

      cdr.write_type_d(data.control_name);

      cdr.write_type_9(data.event_type);

      geometry_msgs.msg.PosePubSubType.write(data.pose, cdr);

      cdr.write_type_4(data.menu_entry_id);

      geometry_msgs.msg.PointPubSubType.write(data.mouse_point, cdr);

      cdr.write_type_7(data.mouse_point_valid);

   }

   public static void read(visualization_msgs.msg.InteractiveMarkerFeedback data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.client_id = cdr.read_type_d();	
      data.marker_name = cdr.read_type_d();	
      data.control_name = cdr.read_type_d();	
      data.event_type=cdr.read_type_9();
      	
      data.pose = geometry_msgs.msg.PosePubSubType.Create();
      geometry_msgs.msg.PosePubSubType.read(data.pose, cdr);
      	
      data.menu_entry_id=cdr.read_type_4();
      	
      data.mouse_point = geometry_msgs.msg.PointPubSubType.Create();
      geometry_msgs.msg.PointPubSubType.read(data.mouse_point, cdr);
      	
      data.mouse_point_valid=cdr.read_type_7();
      	

   }


    public static void Copy(visualization_msgs.msg.InteractiveMarkerFeedback src, visualization_msgs.msg.InteractiveMarkerFeedback target)
    {
        target.Set(src);
    }


}


}