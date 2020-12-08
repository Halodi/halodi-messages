// generated from rosidl_generator_c/resource/idl__struct.h.em
// with input from halodi_msgs:msg/WholeBodyState.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_STATE__STRUCT_H_
#define HALODI_MSGS__MSG__WHOLE_BODY_STATE__STRUCT_H_

#ifdef __cplusplus
extern "C"
{
#endif

#include <stdbool.h>
#include <stddef.h>
#include <stdint.h>


// Constants defined in the message

// Include directives for member types
// Member 'header'
#include "std_msgs/msg/header__struct.h"
// Member 'controller_state'
#include "rosidl_generator_c/string.h"
// Member 'current_balance_mode'
#include "halodi_msgs/msg/balance_mode__struct.h"
// Member 'pose'
#include "geometry_msgs/msg/pose__struct.h"
// Member 'angular_velocity'
// Member 'linear_velocity'
#include "geometry_msgs/msg/vector3__struct.h"
// Member 'imu_measurements'
#include "halodi_msgs/msg/imu_measurement__struct.h"
// Member 'joint_states'
#include "halodi_msgs/msg/joint_measurement__struct.h"
// Member 'taskspace_feedback'
#include "halodi_msgs/msg/task_space_feedback__struct.h"

// constants for array fields with an upper bound
// imu_measurements
enum
{
  halodi_msgs__msg__WholeBodyState__imu_measurements__MAX_SIZE = 2
};
// joint_states
enum
{
  halodi_msgs__msg__WholeBodyState__joint_states__MAX_SIZE = 25
};
// taskspace_feedback
enum
{
  halodi_msgs__msg__WholeBodyState__taskspace_feedback__MAX_SIZE = 5
};

// Struct defined in msg/WholeBodyState in the package halodi_msgs.
typedef struct halodi_msgs__msg__WholeBodyState
{
  std_msgs__msg__Header header;
  int32_t last_received_sequence_id;
  rosidl_generator_c__String controller_state;
  halodi_msgs__msg__BalanceMode current_balance_mode;
  uint8_t robot_status;
  geometry_msgs__msg__Pose pose;
  geometry_msgs__msg__Vector3 angular_velocity;
  geometry_msgs__msg__Vector3 linear_velocity;
  halodi_msgs__msg__ImuMeasurement__Sequence imu_measurements;
  halodi_msgs__msg__JointMeasurement__Sequence joint_states;
  halodi_msgs__msg__TaskSpaceFeedback__Sequence taskspace_feedback;
} halodi_msgs__msg__WholeBodyState;

// Struct for a sequence of halodi_msgs__msg__WholeBodyState.
typedef struct halodi_msgs__msg__WholeBodyState__Sequence
{
  halodi_msgs__msg__WholeBodyState * data;
  /// The number of valid items in data
  size_t size;
  /// The number of allocated items in data
  size_t capacity;
} halodi_msgs__msg__WholeBodyState__Sequence;

#ifdef __cplusplus
}
#endif

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_STATE__STRUCT_H_
