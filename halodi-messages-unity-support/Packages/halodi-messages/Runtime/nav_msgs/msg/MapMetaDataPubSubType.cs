using System.IO;
namespace nav_msgs.msg
{

/**
* 
* Topic data type of the struct "MapMetaData" defined in "MapMetaData.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MapMetaData.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MapMetaData.idl instead.
*
*/
public class MapMetaDataPubSubType : Halodi.CDR.TopicDataType<MapMetaData>
{
   public override string Name => "nav_msgs::msg::dds_::MapMetaData_";


   public static int getCdrSerializedSize(nav_msgs.msg.MapMetaData data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(nav_msgs.msg.MapMetaData data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += builtin_interfaces.msg.TimePubSubType.getCdrSerializedSize(data.map_load_time, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += geometry_msgs.msg.PosePubSubType.getCdrSerializedSize(data.origin, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(nav_msgs.msg.MapMetaData data, Halodi.CDR.CDRSerializer cdr)
   {
      builtin_interfaces.msg.TimePubSubType.write(data.map_load_time, cdr);

      cdr.write_type_5(data.resolution);

      cdr.write_type_4(data.width);

      cdr.write_type_4(data.height);

      geometry_msgs.msg.PosePubSubType.write(data.origin, cdr);

   }

   public static void read(nav_msgs.msg.MapMetaData data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.map_load_time = builtin_interfaces.msg.TimePubSubType.Create();
      builtin_interfaces.msg.TimePubSubType.read(data.map_load_time, cdr);
      	
      data.resolution=cdr.read_type_5();
      	
      data.width=cdr.read_type_4();
      	
      data.height=cdr.read_type_4();
      	
      data.origin = geometry_msgs.msg.PosePubSubType.Create();
      geometry_msgs.msg.PosePubSubType.read(data.origin, cdr);
      	

   }


	public override void Serialize(nav_msgs.msg.MapMetaData data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(nav_msgs.msg.MapMetaData data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(nav_msgs.msg.MapMetaData data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(nav_msgs.msg.MapMetaData src, nav_msgs.msg.MapMetaData target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(nav_msgs.msg.MapMetaData src, nav_msgs.msg.MapMetaData target)
    {
    	Copy(src, target);
    }


}


}