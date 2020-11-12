using System.IO;
namespace nav_msgs.msg
{

/**
* 
* Topic data type of the struct "OccupancyGrid" defined in "OccupancyGrid.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from OccupancyGrid.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit OccupancyGrid.idl instead.
*
*/
public class OccupancyGridPubSubType : Halodi.CDR.TopicDataType<nav_msgs.msg.OccupancyGrid>
{
   public override string Name => "nav_msgs::msg::dds_::OccupancyGrid_";


   
   public override void serialize(nav_msgs.msg.OccupancyGrid data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, nav_msgs.msg.OccupancyGrid data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(nav_msgs.msg.OccupancyGrid data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(nav_msgs.msg.OccupancyGrid data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += nav_msgs.msg.MapMetaDataPubSubType.getCdrSerializedSize(data.info, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.data.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(nav_msgs.msg.OccupancyGrid data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      nav_msgs.msg.MapMetaDataPubSubType.write(data.info, cdr);

      	if(data.data == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int data_length = data.data.Count;
            cdr.write_type_2(data_length);
            for (int i0 = 0; i0 < data_length; i0++)
            {
      			cdr.write_type_9(data.data[i0]);
            }
        }
   }

   public static void read(nav_msgs.msg.OccupancyGrid data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.info = nav_msgs.msg.MapMetaDataPubSubType.Create();
      nav_msgs.msg.MapMetaDataPubSubType.read(data.info, cdr);
      	

      int data_length = cdr.read_type_2();
      data.data = new System.Collections.Generic.List<byte>(data_length);
      for(int i = 0; i < data_length; i++)
      {
      	data.data.Add(cdr.read_type_9());
      	
      	
      }

      	

   }


    public static void Copy(nav_msgs.msg.OccupancyGrid src, nav_msgs.msg.OccupancyGrid target)
    {
        target.Set(src);
    }


}


}