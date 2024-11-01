using UnityEditor;
using BlazeAISpace;

namespace BlazeAISpace 
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(AlertStateBehaviour))]
    public class AlertStateBehaviourInspector : Editor
    {
        SerializedProperty moveSpeed,
        turnSpeed,
        idleAnim,
        moveAnim,
        animT,
        idleTime,
        playAudios,
        audioTime,
        returnToNormal,
        timeToReturnNormal,
        returningDuration,
        returningAnim,
        returningAnimT,
        playAudioOnReturn,
        avoidFacingObstacles,
        obstacleLayers,
        obstacleRayDistance,
        obstacleRayOffset,
        showObstacleRay,
        onStateEnter,
        onStateExit;


        void OnEnable()
        {
            moveSpeed = serializedObject.FindProperty("moveSpeed");
            turnSpeed = serializedObject.FindProperty("turnSpeed");

            idleAnim = serializedObject.FindProperty("idleAnim");
            moveAnim = serializedObject.FindProperty("moveAnim");
            animT = serializedObject.FindProperty("animT");

            idleTime = serializedObject.FindProperty("idleTime");

            playAudios = serializedObject.FindProperty("playAudios");
            audioTime = serializedObject.FindProperty("audioTime");

            returnToNormal = serializedObject.FindProperty("returnToNormal");
            timeToReturnNormal = serializedObject.FindProperty("timeToReturnNormal");
            returningDuration = serializedObject.FindProperty("returningDuration");
            returningAnim = serializedObject.FindProperty("returningAnim");
            returningAnimT = serializedObject.FindProperty("returningAnimT");
            playAudioOnReturn = serializedObject.FindProperty("playAudioOnReturn");

            avoidFacingObstacles = serializedObject.FindProperty("avoidFacingObstacles");
            obstacleLayers = serializedObject.FindProperty("obstacleLayers");
            obstacleRayDistance = serializedObject.FindProperty("obstacleRayDistance");
            obstacleRayOffset = serializedObject.FindProperty("obstacleRayOffset");
            showObstacleRay = serializedObject.FindProperty("showObstacleRay");

            onStateEnter = serializedObject.FindProperty("onStateEnter");
            onStateExit = serializedObject.FindProperty("onStateExit");
        }

        public override void OnInspectorGUI () 
        {
            EditorGUILayout.LabelField("Hover on any property below for insights", EditorStyles.helpBox);
            AlertStateBehaviour script = (AlertStateBehaviour) target;
            int spaceBetween = 20;
            EditorGUILayout.Space(10);
            
            EditorGUILayout.LabelField("Speeds", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(moveSpeed);
            EditorGUILayout.PropertyField(turnSpeed);

            EditorGUILayout.Space(spaceBetween);
            EditorGUILayout.LabelField("Animations", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(idleAnim);
            EditorGUILayout.PropertyField(moveAnim);
            EditorGUILayout.PropertyField(animT);

            EditorGUILayout.Space(spaceBetween);
            EditorGUILayout.LabelField("Idle", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(idleTime);
           
            EditorGUILayout.Space(spaceBetween);
            EditorGUILayout.LabelField("Audios", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(playAudios);
            if (script.playAudios) {
                EditorGUILayout.PropertyField(audioTime);
            }

            EditorGUILayout.Space(spaceBetween);
            EditorGUILayout.LabelField("Return To Normal", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(returnToNormal);
            if (script.returnToNormal) {
                EditorGUILayout.PropertyField(timeToReturnNormal);
                EditorGUILayout.PropertyField(returningDuration);
                EditorGUILayout.PropertyField(returningAnim);
                EditorGUILayout.PropertyField(returningAnimT);
                EditorGUILayout.PropertyField(playAudioOnReturn);
            }

            EditorGUILayout.Space(spaceBetween);
            EditorGUILayout.LabelField("Obstacles", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(avoidFacingObstacles);
            if (script.avoidFacingObstacles) {
                EditorGUILayout.PropertyField(obstacleLayers);
                EditorGUILayout.PropertyField(obstacleRayDistance);
                EditorGUILayout.PropertyField(obstacleRayOffset);
                EditorGUILayout.PropertyField(showObstacleRay);
            }
            EditorGUILayout.Space(spaceBetween);


            EditorGUILayout.LabelField("State Events", EditorStyles.boldLabel);
            EditorGUILayout.PropertyField(onStateEnter);
            EditorGUILayout.PropertyField(onStateExit);


            serializedObject.ApplyModifiedProperties();
        }
    }
}