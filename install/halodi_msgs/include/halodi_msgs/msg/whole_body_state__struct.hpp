// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/WholeBodyState.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_STATE__STRUCT_HPP_
#define HALODI_MSGS__MSG__WHOLE_BODY_STATE__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'header'
#include "std_msgs/msg/header__struct.hpp"
// Member 'current_balance_mode'
#include "halodi_msgs/msg/balance_mode__struct.hpp"
// Member 'pose'
#include "geometry_msgs/msg/pose__struct.hpp"
// Member 'angular_velocity'
// Member 'linear_velocity'
#include "geometry_msgs/msg/vector3__struct.hpp"
// Member 'imu_measurements'
#include "halodi_msgs/msg/imu_measurement__struct.hpp"
// Member 'joint_states'
#include "halodi_msgs/msg/joint_measurement__struct.hpp"
// Member 'taskspace_feedback'
#include "halodi_msgs/msg/task_space_feedback__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__WholeBodyState __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__WholeBodyState __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct WholeBodyState_
{
  using Type = WholeBodyState_<ContainerAllocator>;

  explicit WholeBodyState_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : header(_init),
    current_balance_mode(_init),
    pose(_init),
    angular_velocity(_init),
    linear_velocity(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->last_received_sequence_id = 0l;
      this->controller_state = "";
      this->robot_status = 0;
    }
  }

  explicit WholeBodyState_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : header(_alloc, _init),
    controller_state(_alloc),
    current_balance_mode(_alloc, _init),
    pose(_alloc, _init),
    angular_velocity(_alloc, _init),
    linear_velocity(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->last_received_sequence_id = 0l;
      this->controller_state = "";
      this->robot_status = 0;
    }
  }

  // field types and members
  using _header_type =
    std_msgs::msg::Header_<ContainerAllocator>;
  _header_type header;
  using _last_received_sequence_id_type =
    int32_t;
  _last_received_sequence_id_type last_received_sequence_id;
  using _controller_state_type =
    std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other>;
  _controller_state_type controller_state;
  using _current_balance_mode_type =
    halodi_msgs::msg::BalanceMode_<ContainerAllocator>;
  _current_balance_mode_type current_balance_mode;
  using _robot_status_type =
    unsigned char;
  _robot_status_type robot_status;
  using _pose_type =
    geometry_msgs::msg::Pose_<ContainerAllocator>;
  _pose_type pose;
  using _angular_velocity_type =
    geometry_msgs::msg::Vector3_<ContainerAllocator>;
  _angular_velocity_type angular_velocity;
  using _linear_velocity_type =
    geometry_msgs::msg::Vector3_<ContainerAllocator>;
  _linear_velocity_type linear_velocity;
  using _imu_measurements_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>, 2, typename ContainerAllocator::template rebind<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>>::other>;
  _imu_measurements_type imu_measurements;
  using _joint_states_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointMeasurement_<ContainerAllocator>, 25, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointMeasurement_<ContainerAllocator>>::other>;
  _joint_states_type joint_states;
  using _taskspace_feedback_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>>::other>;
  _taskspace_feedback_type taskspace_feedback;

  // setters for named parameter idiom
  Type & set__header(
    const std_msgs::msg::Header_<ContainerAllocator> & _arg)
  {
    this->header = _arg;
    return *this;
  }
  Type & set__last_received_sequence_id(
    const int32_t & _arg)
  {
    this->last_received_sequence_id = _arg;
    return *this;
  }
  Type & set__controller_state(
    const std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other> & _arg)
  {
    this->controller_state = _arg;
    return *this;
  }
  Type & set__current_balance_mode(
    const halodi_msgs::msg::BalanceMode_<ContainerAllocator> & _arg)
  {
    this->current_balance_mode = _arg;
    return *this;
  }
  Type & set__robot_status(
    const unsigned char & _arg)
  {
    this->robot_status = _arg;
    return *this;
  }
  Type & set__pose(
    const geometry_msgs::msg::Pose_<ContainerAllocator> & _arg)
  {
    this->pose = _arg;
    return *this;
  }
  Type & set__angular_velocity(
    const geometry_msgs::msg::Vector3_<ContainerAllocator> & _arg)
  {
    this->angular_velocity = _arg;
    return *this;
  }
  Type & set__linear_velocity(
    const geometry_msgs::msg::Vector3_<ContainerAllocator> & _arg)
  {
    this->linear_velocity = _arg;
    return *this;
  }
  Type & set__imu_measurements(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>, 2, typename ContainerAllocator::template rebind<halodi_msgs::msg::ImuMeasurement_<ContainerAllocator>>::other> & _arg)
  {
    this->imu_measurements = _arg;
    return *this;
  }
  Type & set__joint_states(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::JointMeasurement_<ContainerAllocator>, 25, typename ContainerAllocator::template rebind<halodi_msgs::msg::JointMeasurement_<ContainerAllocator>>::other> & _arg)
  {
    this->joint_states = _arg;
    return *this;
  }
  Type & set__taskspace_feedback(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>, 5, typename ContainerAllocator::template rebind<halodi_msgs::msg::TaskSpaceFeedback_<ContainerAllocator>>::other> & _arg)
  {
    this->taskspace_feedback = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::WholeBodyState_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::WholeBodyState_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::WholeBodyState_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::WholeBodyState_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::WholeBodyState_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::WholeBodyState_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::WholeBodyState_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::WholeBodyState_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::WholeBodyState_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::WholeBodyState_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__WholeBodyState
    std::shared_ptr<halodi_msgs::msg::WholeBodyState_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__WholeBodyState
    std::shared_ptr<halodi_msgs::msg::WholeBodyState_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const WholeBodyState_ & other) const
  {
    if (this->header != other.header) {
      return false;
    }
    if (this->last_received_sequence_id != other.last_received_sequence_id) {
      return false;
    }
    if (this->controller_state != other.controller_state) {
      return false;
    }
    if (this->current_balance_mode != other.current_balance_mode) {
      return false;
    }
    if (this->robot_status != other.robot_status) {
      return false;
    }
    if (this->pose != other.pose) {
      return false;
    }
    if (this->angular_velocity != other.angular_velocity) {
      return false;
    }
    if (this->linear_velocity != other.linear_velocity) {
      return false;
    }
    if (this->imu_measurements != other.imu_measurements) {
      return false;
    }
    if (this->joint_states != other.joint_states) {
      return false;
    }
    if (this->taskspace_feedback != other.taskspace_feedback) {
      return false;
    }
    return true;
  }
  bool operator!=(const WholeBodyState_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct WholeBodyState_

// alias to use template instance with default allocator
using WholeBodyState =
  halodi_msgs::msg::WholeBodyState_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_STATE__STRUCT_HPP_
